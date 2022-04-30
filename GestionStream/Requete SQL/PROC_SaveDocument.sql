create procedure SaveDocument
(   @NameDoc varchar(100),
	 @DocumentContent Varbinary(5000),
	  @Extension varchar(5)
)
as 
insert into Document(NameDoc,DocumentContent,Extension)
Values(@NameDoc,@DocumentContent,@Extension)