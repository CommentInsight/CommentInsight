package main
import "fmt"
//所谓单行注释，就是每次给一行代码加注释，你可以在任何地方使用以 // 开头的单行注释。

//若果代码量比多，每行加注释，比较麻烦，可以使用多行注释。
func main() {
    // 单行注释

    /*
        多行注释
    */
}

func main1() {
    const (
            a = iota   //0
            b          //1
            c          //2
            d = "ha"   //独立值，iota += 1
            e          //"ha"   iota += 1
            f = 100    //iota +=1
            g          //100  iota +=1
            h = iota   //7,恢复计数
            i          //8
    )
    fmt.Println(a,b,c,d,e,f,g,h,i)
}