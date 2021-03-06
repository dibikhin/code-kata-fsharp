<Query Kind="FSharpProgram" />

// than WTF? is (lst:List<int>) w/ 'L' in '...List...'
let chop num lst =
	let rec chopIter n ls bottom top =
		let mid = (top + bottom) / 2
		let mid_n = (ls: _ list).[mid]
		
		match n with
		| n when bottom > top -> -1
		| n when n > mid_n -> chopIter n ls (mid + 1) top
		| n when n < mid_n -> chopIter n ls bottom (mid - 1)
		| _ -> mid
	
	match lst with
	| [] -> -1
	| _	 -> chopIter num lst 0 (List.length(lst) - 1)

//chop 123456 [1..23456789] |> Dump

chop 3 []  |> Dump
chop 3 [1] |> Dump
chop 3 [4] |> Dump
chop 1 [1] |> Dump

chop 1 [1; 3] |> Dump
chop 3 [1; 3] |> Dump
chop 4 [1; 3] |> Dump
chop 0 [1; 3] |> Dump

chop 1 [1; 3; 5] |> Dump
chop 3 [1; 3; 5] |> Dump
chop 5 [1; 3; 5] |> Dump
chop 0 [1; 3; 5] |> Dump
chop 2 [1; 3; 5] |> Dump
chop 4 [1; 3; 5] |> Dump
chop 6 [1; 3; 5] |> Dump

chop 1 [1; 3; 5; 7] |> Dump
chop 3 [1; 3; 5; 7] |> Dump
chop 5 [1; 3; 5; 7] |> Dump
chop 7 [1; 3; 5; 7] |> Dump
chop 0 [1; 3; 5; 7] |> Dump
chop 2 [1; 3; 5; 7] |> Dump
chop 4 [1; 3; 5; 7] |> Dump
chop 6 [1; 3; 5; 7] |> Dump
chop 8 [1; 3; 5; 7] |> Dump

chop 8  [1; 3; 5; 7; 9] 	|> Dump
chop 8  [1; 3; 5; 7; 9; 11] |> Dump
chop 10 [1; 3; 5; 7; 9; 11] |> Dump
chop 12 [1; 3; 5; 7; 9; 11] |> Dump
chop 6  [1; 3; 5; 7; 9; 11] |> Dump