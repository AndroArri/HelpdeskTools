SELECT DISTINCT o.Name as TableName

FROM sysobjects o

JOIN syscolumns c

ON o.id = c.id

JOIN systypes t

ON c.xtype = t.xtype

WHERE o.xtype = 'u' 

ORDER By o.name