create procedure GetDocuments
as
select IdDoc,NameDoc,DocumentContent,Extension
from dbo.Document