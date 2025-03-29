const fs = require('fs');
const path = require('path');

// Directory containing TypeScript files
const modelDir = path.join(__dirname, 'src');

// Output file path
const indexFilePath = path.join('./', 'index.ts');

// Ensure src directory exists
if (!fs.existsSync(modelDir)) {
  fs.mkdirSync(modelDir, { recursive: true });
}

// Get all TypeScript files
const tsFiles = fs.readdirSync(modelDir)
  .filter(file => file.endsWith('.ts'));

// Generate export statements
const exportStatements = tsFiles.map(file => {
  const baseName = path.basename(file, '.ts');
  return `export * from './src/${baseName}';`;
}).join('\n');

// Add header comment
const fileContent = `// Generated barrel exports for Matoa models
// This file is auto-generated. Do not edit directly.

${exportStatements}
`;

// Write the index file
fs.writeFileSync(indexFilePath, fileContent);

console.log(`Generated index.ts with ${tsFiles.length} exports.`);
