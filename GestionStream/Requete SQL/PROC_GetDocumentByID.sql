create procedure GetDocument
(
	@IdDoc int
)
as 
select IdDoc,NameDoc,DocumentContent,Extension
from	Document
where IdDoc=@IdDoc