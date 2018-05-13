﻿using NUnit.Framework;
using UniJSON;


public class SchemaTests
{
    /// <summary>
    /// http://json-schema.org/examples.html
    /// </summary>
    public class Person
    {
        [JsonSchemaPropertyAttribute(true)]
        public string firstName;

        [JsonSchemaPropertyAttribute(true)]
        public string lastName;

        [JsonSchemaPropertyAttribute(false, "Age in years", 0)]
        public int age;
    }

    [Test]
    public void Tests()
    {
        var s = JsonSchema.Create<Person>();
        Assert.AreEqual("Person", s.Title);
        Assert.AreEqual("object", s.Type);
        Assert.AreEqual("string", s.Properties["firstName"].Type);
        Assert.AreEqual("string", s.Properties["lastName"].Type);
        Assert.AreEqual("integer", s.Properties["age"].Type);
        Assert.AreEqual("Age in years", s.Properties["age"].Description);
        Assert.AreEqual(0, s.Properties["age"].Minimum);
        Assert.AreEqual(new[] { "firstName", "lastName" }, s.Required);
    }
}