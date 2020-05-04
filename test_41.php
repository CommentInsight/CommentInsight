<?php
//第一行注释
echo "HELLO";
echo "<br> ";

#第二行注释
echo "PHP中文网";

/* 以下代码行
 将输出“Hello World！”  */
echo "Hello Worldn!";

// 这样事单行注释
# 这样也是单行注释，但是很多教程里并没有说这种方式
/*
 * 这样是多行注释
 */ 

?>


<?php
$name="变量会被解析";
$a=<<<EOF
$name<br><a>html格式会被解析</a><br/>双引号和Html格式外的其他内容都不会被解析
"双引号外所有被排列好的格式都会被保留"
"但是双引号内会保留转义符的转义效果,比如table:\t和换行：\n下一行"
EOF;
echo $a;
?>  