# SafetyChatbot

Fixed while loop condition from (input == "") to (true)
Added the '.ToLower()' conversion for case-insensitive input matching
Added FileNotFoundException handler for missing audio file
Added FormatException handler for invalid number input
Fixed the error in audio file path so the sound could play
Fixed file path using Path.Combine() instead of .Replace()
