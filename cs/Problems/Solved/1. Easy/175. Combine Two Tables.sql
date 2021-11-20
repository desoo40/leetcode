# Write your MySQL query statement below
select FirstName, LastName, City, State
FROM Person LEFT JOIN Address
ON Person.PersonId=Address.PersonId    ;