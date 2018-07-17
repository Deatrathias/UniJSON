﻿using System;


namespace UniJSON
{
    /// <summary>
    /// http://json-schema.org/latest/json-schema-validation.html#numeric
    /// </summary>
    public class JsonIntValidator : JsonSchemaValidatorBase
    {
        public override JsonValueType JsonValueType { get { return JsonValueType.Integer; } }

        /// <summary>
        /// http://json-schema.org/latest/json-schema-validation.html#rfc.section.6.2.1
        /// </summary>
        public int? MultipleOf
        {
            get; set;
        }

        /// <summary>
        /// http://json-schema.org/latest/json-schema-validation.html#rfc.section.6.2.2
        /// </summary>
        public int? Maximum
        {
            get; set;
        }

        /// <summary>
        /// http://json-schema.org/latest/json-schema-validation.html#rfc.section.6.2.3
        /// </summary>
        public bool ExclusiveMaximum
        {
            get; set;
        }

        /// <summary>
        /// http://json-schema.org/latest/json-schema-validation.html#rfc.section.6.2.4
        /// </summary>
        public int? Minimum
        {
            get; set;
        }

        /// <summary>
        /// http://json-schema.org/latest/json-schema-validation.html#rfc.section.6.2.5
        /// </summary>
        public bool ExclusiveMinimum
        {
            get; set;
        }

        public override bool Parse(IFileSystemAccessor fs, string key, JsonNode value)
        {
            switch (key)
            {
                case "multipleOf":
                    MultipleOf = value.GetInt32();
                    return true;

                case "maximum":
                    Maximum = value.GetInt32();
                    return true;

                case "exclusiveMaximum":
                    ExclusiveMaximum = value.GetBoolean();
                    return true;

                case "minimum":
                    Minimum = value.GetInt32();
                    return true;

                case "exclusiveMinimum":
                    ExclusiveMinimum = value.GetBoolean();
                    return true;
            }

            return false;
        }

        public override void Assign(JsonSchemaValidatorBase obj)
        {
            var rhs = obj as JsonIntValidator;
            if (rhs == null)
            {
                throw new ArgumentException();
            }

            MultipleOf = rhs.MultipleOf;
            Maximum = rhs.Maximum;
            ExclusiveMaximum = rhs.ExclusiveMaximum;
            Minimum = rhs.Minimum;
            ExclusiveMinimum = rhs.ExclusiveMinimum;
        }

        public override int GetHashCode()
        {
            return 2;
        }

        public override bool Equals(object obj)
        {
            var rhs = obj as JsonIntValidator;
            if (rhs == null) return false;

            if (MultipleOf != rhs.MultipleOf)
            {
                Console.WriteLine("MultipleOf");
                return false;
            }
            if (Maximum != rhs.Maximum)
            {
                Console.WriteLine("Maximum");
                return false;
            }

            if (ExclusiveMaximum != rhs.ExclusiveMaximum)
            {
                Console.WriteLine("ExclusiveMaximum");
                return false;
            }

            if (Minimum != rhs.Minimum)
            {
                Console.WriteLine("Minimum");
                return false;
            }

            if (ExclusiveMinimum != rhs.ExclusiveMinimum)
            {
                Console.WriteLine("ExclusiveMinimum");
                return false;
            }

            return true;
        }

        public override void Serialize(JsonFormatter f, object o)
        {
            f.Value((int)o);
        }
    }

    /// <summary>
    /// http://json-schema.org/latest/json-schema-validation.html#numeric
    /// </summary>
    public class JsonNumberValidator : JsonSchemaValidatorBase
    {
        public override JsonValueType JsonValueType { get { return JsonValueType.Number; } }

        /// <summary>
        /// http://json-schema.org/latest/json-schema-validation.html#rfc.section.6.2.1
        /// </summary>
        public double? MultipleOf
        {
            get; set;
        }

        /// <summary>
        /// http://json-schema.org/latest/json-schema-validation.html#rfc.section.6.2.2
        /// </summary>
        public double? Maximum
        {
            get; set;
        }

        /// <summary>
        /// http://json-schema.org/latest/json-schema-validation.html#rfc.section.6.2.3
        /// </summary>
        public bool ExclusiveMaximum
        {
            get; set;
        }

        /// <summary>
        /// http://json-schema.org/latest/json-schema-validation.html#rfc.section.6.2.4
        /// </summary>
        public double? Minimum
        {
            get; set;
        }

        /// <summary>
        /// http://json-schema.org/latest/json-schema-validation.html#rfc.section.6.2.5
        /// </summary>
        public bool ExclusiveMinimum
        {
            get; set;
        }

        public override void Assign(JsonSchemaValidatorBase rhs)
        {
            throw new NotImplementedException();
        }

        public override bool Parse(IFileSystemAccessor fs, string key, JsonNode value)
        {
            switch (key)
            {
                case "multipleOf":
                    MultipleOf = value.GetDouble();
                    return true;

                case "maximum":
                    Maximum = value.GetDouble();
                    return true;

                case "exclusiveMaximum":
                    ExclusiveMaximum = value.GetBoolean();
                    return true;

                case "minimum":
                    Minimum = value.GetDouble();
                    return true;

                case "exclusiveMinimum":
                    ExclusiveMinimum = value.GetBoolean();
                    return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return 3;
        }

        public override bool Equals(object obj)
        {
            var rhs = obj as JsonNumberValidator;
            if (rhs == null) return false;

            if (MultipleOf != rhs.MultipleOf) return false;
            if (Maximum != rhs.Maximum) return false;
            if (ExclusiveMaximum != rhs.ExclusiveMaximum) return false;
            if (Minimum != rhs.Minimum) return false;
            if (ExclusiveMinimum != rhs.ExclusiveMinimum) return false;

            return true;
        }

        public override void Serialize(JsonFormatter f, object o)
        {
            throw new NotImplementedException();
        }
    }
}