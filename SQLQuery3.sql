declare @bookid int 
set @bookid=69
declare @class int
select @class=category.classificationCode from category join book on book.categoryId=category.classificationCode  where book.ISBN=@bookid
update category set BooksCount=BooksCount-1 where classificationCode=@class