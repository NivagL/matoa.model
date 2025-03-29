namespace matoa.model.test;

[TestClass]
[TestCategory("Unit")]
public sealed class TupleHelperTest
{
  [TestMethod]
  public void GetStringValues_NullInput_ReturnsEmptyStringArray()
  {
    // Arrange
    object key = null;

    // Act
    var result = TupleHelper.GetStringValues(key);

    // Assert
    CollectionAssert.AreEqual(new string[] { }, result);
  }

  [TestMethod]
  public void GetStringValues_SingleValue_ReturnsStringArrayWithSingleValue()
  {
    // Arrange
    int key = 42;

    // Act
    var result = TupleHelper.GetStringValues(key);

    // Assert
    CollectionAssert.AreEqual(new[] { "42" }, result);
  }

  [TestMethod]
  public void GetStringValues_ValueTuple_ReturnsStringArrayWithValues()
  {
    // Arrange
    var key = (1, "test", 3.14);

    // Act
    var result = TupleHelper.GetStringValues(key);

    // Assert
    CollectionAssert.AreEqual(new[] { "1", "test", "3.14" }, result);
  }

  [TestMethod]
  public void GetStringValues_Tuple_ReturnsStringArrayWithValues()
  {
    // Arrange
    var key = Tuple.Create(1, "test", 3.14);

    // Act
    var result = TupleHelper.GetStringValues(key);

    // Assert
    CollectionAssert.AreEqual(new[] { "1", "test", "3.14" }, result);
  }

  [TestMethod]
  public void GetStringValues_EmptyValueTuple_ReturnsEmptyStringArray()
  {
    // Arrange
    var key = ValueTuple.Create();

    // Act
    var result = TupleHelper.GetStringValues(key);

    // Assert
    CollectionAssert.AreEqual(new string[] { }, result);
  }

  [TestMethod]
  public void GetStringValues_EmptyTuple_ReturnsEmptyStringArray()
  {
    // Arrange
    var key = Tuple.Create<object>(null);

    // Act
    var result = TupleHelper.GetStringValues(key);

    // Assert
    CollectionAssert.AreEqual(new string[] { }, result);
  }
}
