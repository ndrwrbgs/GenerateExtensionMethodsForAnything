namespace SystemExtensions
{
	public static class StringExtensions
	{


		/// <inheritdoc cref="System.String.IsNullOrWhiteSpace(System.String)" />
		public static System.Boolean IsNullOrWhiteSpace(this System.String value)
		{
			return System.String.IsNullOrWhiteSpace(value);
		}

		/// <inheritdoc cref="System.String.IsNullOrEmpty(System.String)" />
		public static System.Boolean IsNullOrEmpty(this System.String value)
		{
			return System.String.IsNullOrEmpty(value);
		}

		/// <inheritdoc cref="System.String.Concat(System.Object)" />
		public static System.String Concat(this System.Object arg0)
		{
			return System.String.Concat(arg0);
		}

		/// <inheritdoc cref="System.String.Concat(System.Object, System.Object)" />
		public static System.String Concat(this System.Object arg0, System.Object arg1)
		{
			return System.String.Concat(arg0, arg1);
		}

		/// <inheritdoc cref="System.String.Concat(System.Object, System.Object, System.Object)" />
		public static System.String Concat(this System.Object arg0, System.Object arg1, System.Object arg2)
		{
			return System.String.Concat(arg0, arg1, arg2);
		}

		/// <inheritdoc cref="System.String.Concat(System.Object, System.Object, System.Object, System.Object)" />
		public static System.String Concat(this System.Object arg0, System.Object arg1, System.Object arg2, System.Object arg3)
		{
			return System.String.Concat(arg0, arg1, arg2, arg3);
		}

		/// <inheritdoc cref="System.String.Concat(System.Object[])" />
		public static System.String Concat(this System.Object[] args)
		{
			return System.String.Concat(args);
		}

		/// <inheritdoc cref="System.String.Concat(System.String, System.String)" />
		public static System.String Concat(this System.String str0, System.String str1)
		{
			return System.String.Concat(str0, str1);
		}

		/// <inheritdoc cref="System.String.Concat(System.String, System.String, System.String)" />
		public static System.String Concat(this System.String str0, System.String str1, System.String str2)
		{
			return System.String.Concat(str0, str1, str2);
		}

		/// <inheritdoc cref="System.String.Concat(System.String, System.String, System.String, System.String)" />
		public static System.String Concat(this System.String str0, System.String str1, System.String str2, System.String str3)
		{
			return System.String.Concat(str0, str1, str2, str3);
		}

		/// <inheritdoc cref="System.String.Concat(System.String[])" />
		public static System.String Concat(this System.String[] values)
		{
			return System.String.Concat(values);
		}

		/// <inheritdoc cref="System.String.Join(System.String, System.String[])" />
		public static System.String Join(this System.String separator, System.String[] value)
		{
			return System.String.Join(separator, value);
		}

		/// <inheritdoc cref="System.String.Join(System.String, System.Object[])" />
		public static System.String Join(this System.String separator, System.Object[] values)
		{
			return System.String.Join(separator, values);
		}

		/// <inheritdoc cref="System.String.Join(System.String, System.String[], System.Int32, System.Int32)" />
		public static System.String Join(this System.String separator, System.String[] value, System.Int32 startIndex, System.Int32 count)
		{
			return System.String.Join(separator, value, startIndex, count);
		}

		/// <inheritdoc cref="System.String.Equals(System.String, System.String)" />
		public static System.Boolean Equals(this System.String a, System.String b)
		{
			return System.String.Equals(a, b);
		}

		/// <inheritdoc cref="System.String.Equals(System.String, System.String, System.StringComparison)" />
		public static System.Boolean Equals(this System.String a, System.String b, System.StringComparison comparisonType)
		{
			return System.String.Equals(a, b, comparisonType);
		}

		/// <inheritdoc cref="System.String.Compare(System.String, System.String)" />
		public static System.Int32 Compare(this System.String strA, System.String strB)
		{
			return System.String.Compare(strA, strB);
		}

		/// <inheritdoc cref="System.String.Compare(System.String, System.String, System.Boolean)" />
		public static System.Int32 Compare(this System.String strA, System.String strB, System.Boolean ignoreCase)
		{
			return System.String.Compare(strA, strB, ignoreCase);
		}

		/// <inheritdoc cref="System.String.Compare(System.String, System.String, System.StringComparison)" />
		public static System.Int32 Compare(this System.String strA, System.String strB, System.StringComparison comparisonType)
		{
			return System.String.Compare(strA, strB, comparisonType);
		}

		/// <inheritdoc cref="System.String.Compare(System.String, System.String, System.Globalization.CultureInfo, System.Globalization.CompareOptions)" />
		public static System.Int32 Compare(this System.String strA, System.String strB, System.Globalization.CultureInfo culture, System.Globalization.CompareOptions options)
		{
			return System.String.Compare(strA, strB, culture, options);
		}

		/// <inheritdoc cref="System.String.Compare(System.String, System.String, System.Boolean, System.Globalization.CultureInfo)" />
		public static System.Int32 Compare(this System.String strA, System.String strB, System.Boolean ignoreCase, System.Globalization.CultureInfo culture)
		{
			return System.String.Compare(strA, strB, ignoreCase, culture);
		}

		/// <inheritdoc cref="System.String.Compare(System.String, System.Int32, System.String, System.Int32, System.Int32)" />
		public static System.Int32 Compare(this System.String strA, System.Int32 indexA, System.String strB, System.Int32 indexB, System.Int32 length)
		{
			return System.String.Compare(strA, indexA, strB, indexB, length);
		}

		/// <inheritdoc cref="System.String.Compare(System.String, System.Int32, System.String, System.Int32, System.Int32, System.Boolean)" />
		public static System.Int32 Compare(this System.String strA, System.Int32 indexA, System.String strB, System.Int32 indexB, System.Int32 length, System.Boolean ignoreCase)
		{
			return System.String.Compare(strA, indexA, strB, indexB, length, ignoreCase);
		}

		/// <inheritdoc cref="System.String.Compare(System.String, System.Int32, System.String, System.Int32, System.Int32, System.Boolean, System.Globalization.CultureInfo)" />
		public static System.Int32 Compare(this System.String strA, System.Int32 indexA, System.String strB, System.Int32 indexB, System.Int32 length, System.Boolean ignoreCase, System.Globalization.CultureInfo culture)
		{
			return System.String.Compare(strA, indexA, strB, indexB, length, ignoreCase, culture);
		}

		/// <inheritdoc cref="System.String.Compare(System.String, System.Int32, System.String, System.Int32, System.Int32, System.Globalization.CultureInfo, System.Globalization.CompareOptions)" />
		public static System.Int32 Compare(this System.String strA, System.Int32 indexA, System.String strB, System.Int32 indexB, System.Int32 length, System.Globalization.CultureInfo culture, System.Globalization.CompareOptions options)
		{
			return System.String.Compare(strA, indexA, strB, indexB, length, culture, options);
		}

		/// <inheritdoc cref="System.String.Compare(System.String, System.Int32, System.String, System.Int32, System.Int32, System.StringComparison)" />
		public static System.Int32 Compare(this System.String strA, System.Int32 indexA, System.String strB, System.Int32 indexB, System.Int32 length, System.StringComparison comparisonType)
		{
			return System.String.Compare(strA, indexA, strB, indexB, length, comparisonType);
		}

		/// <inheritdoc cref="System.String.CompareOrdinal(System.String, System.String)" />
		public static System.Int32 CompareOrdinal(this System.String strA, System.String strB)
		{
			return System.String.CompareOrdinal(strA, strB);
		}

		/// <inheritdoc cref="System.String.CompareOrdinal(System.String, System.Int32, System.String, System.Int32, System.Int32)" />
		public static System.Int32 CompareOrdinal(this System.String strA, System.Int32 indexA, System.String strB, System.Int32 indexB, System.Int32 length)
		{
			return System.String.CompareOrdinal(strA, indexA, strB, indexB, length);
		}

		/// <inheritdoc cref="System.String.Format(System.String, System.Object)" />
		public static System.String Format(this System.String format, System.Object arg0)
		{
			return System.String.Format(format, arg0);
		}

		/// <inheritdoc cref="System.String.Format(System.String, System.Object, System.Object)" />
		public static System.String Format(this System.String format, System.Object arg0, System.Object arg1)
		{
			return System.String.Format(format, arg0, arg1);
		}

		/// <inheritdoc cref="System.String.Format(System.String, System.Object, System.Object, System.Object)" />
		public static System.String Format(this System.String format, System.Object arg0, System.Object arg1, System.Object arg2)
		{
			return System.String.Format(format, arg0, arg1, arg2);
		}

		/// <inheritdoc cref="System.String.Format(System.String, System.Object[])" />
		public static System.String Format(this System.String format, System.Object[] args)
		{
			return System.String.Format(format, args);
		}

		/// <inheritdoc cref="System.String.Format(System.IFormatProvider, System.String, System.Object)" />
		public static System.String Format(this System.IFormatProvider provider, System.String format, System.Object arg0)
		{
			return System.String.Format(provider, format, arg0);
		}

		/// <inheritdoc cref="System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)" />
		public static System.String Format(this System.IFormatProvider provider, System.String format, System.Object arg0, System.Object arg1)
		{
			return System.String.Format(provider, format, arg0, arg1);
		}

		/// <inheritdoc cref="System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object, System.Object)" />
		public static System.String Format(this System.IFormatProvider provider, System.String format, System.Object arg0, System.Object arg1, System.Object arg2)
		{
			return System.String.Format(provider, format, arg0, arg1, arg2);
		}

		/// <inheritdoc cref="System.String.Format(System.IFormatProvider, System.String, System.Object[])" />
		public static System.String Format(this System.IFormatProvider provider, System.String format, System.Object[] args)
		{
			return System.String.Format(provider, format, args);
		}

		/// <inheritdoc cref="System.String.Copy(System.String)" />
		public static System.String Copy(this System.String str)
		{
			return System.String.Copy(str);
		}

		/// <inheritdoc cref="System.String.Intern(System.String)" />
		public static System.String Intern(this System.String str)
		{
			return System.String.Intern(str);
		}

		/// <inheritdoc cref="System.String.IsInterned(System.String)" />
		public static System.String IsInterned(this System.String str)
		{
			return System.String.IsInterned(str);
		} 
	}
}
