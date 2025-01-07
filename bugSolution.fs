let x = ref 1
let y = x

x := 2
printf "%d %d" x.Value y.Value