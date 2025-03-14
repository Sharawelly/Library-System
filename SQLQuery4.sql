declare @id int
declare @ISBN int
set @ISBN=81
declare @auname nvarchar(100)
set @auname='dk'

select @id=book.authorId from book join author on book.authorId=author.id where ISBN=@ISBN update author set [Name]=@auname where id=@id select @id
declare @id int declare @ISBN int declare @auname nvarchar(100) select @id=book.authorId from book join author on book.authorId=author.id where ISBN=@ISBN update author set [Name]=@auname where id=@id select @id