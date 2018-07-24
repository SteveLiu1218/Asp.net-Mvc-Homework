# Asp.net-Mvc-Homework
[Day 1]

各位的壓縮檔案中有一個「SampleCode」資料夾，裡面有一個「MoneyTemplate.html」檔案這就是假裝設計師給你的樣板。

你必須開一個新的MVC專案，並且建立好以後就上傳至 GitHub 一次（這時候簽入的應該都是範本程式）

將提供的「MoneyTemplate.html」套用到你的專案中，一定要使用 Layout！

下方列表務必要分開（Child Action or PartialView），並且要有假資料50筆（禁止寫在 HTML）所以說你要利用 ViewModel 製作假資料

上方輸入的部分可以只是切版的結果，目前可以不用實現功能。

範例列表前的數字是「每一頁的流水號」並非 DB 的值。

此版本禁止建立 DB ，一切都要是假資料。

[Day2]

請將記帳本呈現資料的部分改為真 DB !

資料庫在範例檔案的 HomeWorkDB 內，將資料庫複製到你專案的 App_Data 內即可

可使用 EF , ADO.NET 任何一種操作資料庫的方式

不可改變第一天設計的 ViewModel 

將記帳本的寫入功能完成。

必須真的寫進資料庫

所有欄位必填

1.「金額」只能輸入正整數

2.「日期」不得大於今天

3.「備註」最多輸入100個字元（備註為 TextArea）

列表加入顏色變換

1.類型的「支出」字樣顯現為紅色

2.類型的「收入」字樣顯現為藍色

建議練習

實做 Service 層

額外挑戰

UnitOfWork

Repository

