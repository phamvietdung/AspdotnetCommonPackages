## NullExtensions
| Property  | Return | Description  |
|---|---|---|
| **IsNull**<T>(this T source)  | Boolean  | Return true if T is null, and false if not  |
| **IsNotNull**<T>(this T source)  | Boolean  | Return true if T is not null, and false if null  |
| **IsNotDefault**<T>(this T source)  | Boolean  | Return true if T is not equal default(T) value  |
| **IsNotNulAndNotDefault**<T>(this T source)  | Boolean  | Return true if T is not null and not equivalent with default(T) value  |
| **IsNotNullAndHaveData**<T>(this **ICollection**<T> sources)  | Boolean  | Return true if ICollection<T> it not null and have data  |

## DatetimeExtensions
| Property  | Return | Description  |
|---|---|---|
| **GetParseableToDateTimeFormat**(this string source, CultureInfo cultureInfo = null)  | KeyValuePair<string, DateTime>  | Try parse the input string in all type of **DateTimeFormatInfo** and return **KeyValuePair** with name of this DateTime parse Pattern and DataTime value after parse |

## TextExtensions
| Property  | Return | Description  |
|---|---|---|
| **Masking**(this string source, string alternative_character = "*", int ratioHidden = 60)  | String  | Try masking the output text with alternative_character with ratio of hidden character is greater ratioHidden |
| **ReplaceUnicodeCharacterByTheASIICharacter**(this string source, bool convertToLowerCase = true)  | String  | Replace all unicode character with ASII character ("á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ" => "a").|
| **ReplaceSpecialCharacterByUnderLineCharacter**(this string source, string alternativeCharacter = "_")  | String  | Replace all special character with their alternative.|
| **ToAlias**  | String  | Combine **ReplaceUnicodeCharacterByTheASIICharacter** and **ReplaceSpecialCharacterByUnderLineCharacter**.|
