# Matoa Model Library

This library contains the data models for the Matoa application. It's published as both a NuGet package (for .NET applications) and an npm package (for TypeScript/JavaScript applications).

## Structure

- `src/csharp`: C# model classes
- `src/typescript`: TypeScript interfaces generated from C# classes

## Development

### Prerequisites

- .NET SDK 8.0 or later
- Node.js 18 or later
- npm 9 or later

### Building

To build the library and generate TypeScript definitions:

```bash
dotnet build
```

To build the npm package:

```bash
npm run build
```

### Publishing

Both packages are automatically published to GitHub Packages via GitHub Actions.

## Usage

### .NET (C#)

```csharp
using Matoa.Model;

var event = new Event { 
    Name = "Community Meeting",
    EventStart = DateTimeOffset.Now.AddDays(7)
};
```

### TypeScript/JavaScript

```typescript
import { Event } from '@matoa/model';

const event: Event = {
    name: "Community Meeting",
    eventStart: new Date(Date.now() + 7 * 24 * 60 * 60 * 1000)
};
```
