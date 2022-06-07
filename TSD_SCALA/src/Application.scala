object Application extends App {

  //task 1 tests
  println(task1("aaaa"))
  println(task1("aaaaa"))
  println(task1("aaaaaa"))

  //task2 tests
  println(task2(3, List(9, 2, 3, 4, 5, 6, 7)))

  //task3 tests
  task3("ABC", "XD", "ABCxaXDcxcABCABCdsasABCXDXD")


  def task1(text: String): String = {
    if (text.length <= 4){
      return text.toUpperCase()
    }
    text.substring(0, text.length - 4).concat(text.substring(text.length - 4).toUpperCase())
  }

  def task2(n: Int, array: List[Int]): Int = {
    if (n > array.size) {
      return -1;
    }

    val seqSize = array.size - n + 1
    var chosenSubArray = array.take(n)
    var currentSum = array.take(n).sum

    for( i <- 0 to seqSize) {
      val nextSum = array.slice(i, i + n).sum
      if (nextSum < currentSum ){
        currentSum = nextSum
        chosenSubArray = array.slice(i, i + n)
      }
    }
    currentSum
  }

  def task3(string1: String, string2: String, text: String) = {
    println(string1 + " occurences in text: " + (text.split(string1, -1 ).length - 1))
    println(string2 + " occurences in text: " + (text.split(string2, -1 ).length - 1))
  }
}
