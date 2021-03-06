﻿using NToolbox.Globalization;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NToolbox.NUnit.Data
{
	public static class ExceptionData
	{
		#region Public Constants
		public const string Message = "Custom Message";
		public const string Parameter = "Custom Parameter";
		#endregion

		#region Public Static Properties
		public static ReadOnlyDictionary<Culture, string> ArgumentEmptyExceptionDefaultMessage
		{
			get
			{
				Dictionary<Culture, string> dict = new Dictionary<Culture, string>();
				dict.Add(Culture.en, "Exception of type 'NToolbox.ArgumentEmptyException' was thrown.");
				dict.Add(Culture.de, "Eine Ausnahme vom Typ \"NToolbox.ArgumentEmptyException\" wurde ausgelöst.");

				return new ReadOnlyDictionary<Culture, string>(dict);
			}
		}

		public static ReadOnlyDictionary<Culture, string> ArgumentEmptyExceptionMessage
		{
			get
			{
				Dictionary<Culture, string> dict = new Dictionary<Culture, string>();
				dict.Add(Culture.en, "Value cannot be empty.");
				dict.Add(Culture.de, "Der Wert darf nicht leer sein.");

				return new ReadOnlyDictionary<Culture, string>(dict);
			}
		}

		public static ReadOnlyDictionary<Culture, string> ArgumentNullExceptionDefaultMessage
		{
			get
			{
				Dictionary<Culture, string> dict = new Dictionary<Culture, string>();
				dict.Add(Culture.en, "Exception of type 'System.ArgumentNullException' was thrown.");
				dict.Add(Culture.de, "Eine Ausnahme vom Typ \"System.ArgumentNullException\" wurde ausgelöst.");

				return new ReadOnlyDictionary<Culture, string>(dict);
			}
		}

		public static ReadOnlyDictionary<Culture, string> ArgumentNullExceptionMessage
		{
			get
			{
				Dictionary<Culture, string> dict = new Dictionary<Culture, string>();
				dict.Add(Culture.en, "Value cannot be null.");
				dict.Add(Culture.de, "Der Wert darf nicht NULL sein.");

				return new ReadOnlyDictionary<Culture, string>(dict);
			}
		}

		public static ReadOnlyDictionary<Culture, string> ArgumentWhiteSpaceExceptionDefaultMessage
		{
			get
			{
				Dictionary<Culture, string> dict = new Dictionary<Culture, string>();
				dict.Add(Culture.en, "Exception of type 'NToolbox.ArgumentWhiteSpaceException' was thrown.");
				dict.Add(Culture.de, "Eine Ausnahme vom Typ \"NToolbox.ArgumentWhiteSpaceException\" wurde ausgelöst.");

				return new ReadOnlyDictionary<Culture, string>(dict);
			}
		}

		public static ReadOnlyDictionary<Culture, string> ArgumentWhiteSpaceExceptionMessage
		{
			get
			{
				Dictionary<Culture, string> dict = new Dictionary<Culture, string>();
				dict.Add(Culture.en, "Value cannot consists only of white-space characters.");
				dict.Add(Culture.de, "Der Wert darf nicht nur aus Leerzeichen bestehen.");

				return new ReadOnlyDictionary<Culture, string>(dict);
			}
		}
		#endregion
	}
}