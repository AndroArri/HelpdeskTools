SELECT 
o.Name as TableName,
c.Name as ColumnName,

t.name as DataType,

t.length as [DataLength]

FROM sysobjects o

JOIN syscolumns c

ON o.id = c.id

JOIN systypes t

ON c.xtype = t.xtype

WHERE o.xtype = 'u' and t.name <> 'sysname'

ORDER By o.name, C.name