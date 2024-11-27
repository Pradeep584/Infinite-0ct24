use Pradeep_db

 select *
from books
where author Like '%er'


select reviewer_name,
COUNT(book_id) as review_count
from reviews 
group by reviewer_name
having COUNT(book_id) > 1

select title,
author,
reviewer_name
from books 
join reviews 
on 
books.id = reviews.book_id

select NAME,ADDRESS from Customertable where ADDRESS like '%o%'

select LOWER(name) from Employee where SALARY is null


select Gender, count(*) as Total from Std_Details 
group by Gender


select date,count(*) as'No.of customers'
from Orders
group by date