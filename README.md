# Asp.net-Mvc-Homework

[Day 1]
---

1.將提供的「MoneyTemplate.html」套用到你的專案中，一定要使用 Layout!  
2.下方列表務必要分開（Child Action or PartialView），並且要有假資料50筆（禁止寫在 HTML）所以說你要利用 ViewModel 製作假資料  
3.上方輸入的部分可以只是切版的結果，目前可以不用實現功能。  
4.範例列表前的數字是「每一頁的流水號」並非 DB 的值。  
5.此版本禁止建立 DB ，一切都要是假資料。  

[Day2]
----
1.請將記帳本呈現資料的部分改為真 DB !  
2.可使用 EF , ADO.NET 任何一種操作資料庫的方式  [從資料庫Code first]
3.不可改變第一天設計的 ViewModel   

所有欄位必填 (ValidationAttribute)

1.「金額」只能輸入正整數  (ModelAttribute Range)
2.「日期」不得大於今天  (自定義繼承ValidationAttribute 和 覆寫 IsValid)
3.「備註」最多輸入100個字元（備註為 TextArea）  (Html.TextAreaFor() 

列表加入顏色變換 (用Helper來做)

1.類型的「支出」字樣顯現為紅色  
2.類型的「收入」字樣顯現為藍色  

建議練習  
實做 Service 層  

額外挑戰  

UnitOfWork  
Repository

