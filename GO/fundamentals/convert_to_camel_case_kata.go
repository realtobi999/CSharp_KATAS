package fundamentals

import (
	"unicode"
)

/*
	Zadání:
		Complete the method/function so that  it  converts  dash/underscore  delimited
		words  into  camel  casing.  The  first  word  within  the  output  should  be
		capitalized only if the original word was capitalized (known  as  Upper  Camel
		Case, also often referred to as Pascal case). The next words should be  always
		capitalized.
	Řešení:
		We loop over each of the character, if the character is '_' or '-'  we  assume
		the next character has to be capitalized.
*/
func ToCamelCase(s string) string {
	result := ""
	nextUpper := false

	for _, char := range result {
		if char == '_' || char == '-' {
			nextUpper = true
			continue
		}

		if nextUpper {
			result += string(unicode.ToUpper(char))
			nextUpper = false
		} else {
			result += string(char)
		}
	}

	return result
}