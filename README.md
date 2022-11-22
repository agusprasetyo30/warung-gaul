# UAS Pemrograman Visual

<img src="demo.gif" width="100%">
<p align=center>
<small>Demo Project</small>
</p>

## Requirement
- Visual Studio
- C#
- Database : SQL Server

## Database
  - customer
    - id (int PK)
    - name (varchar)

  - item
    - id (int PK)
    - name (varchar)
    - category (varchar)
    - price (decimal)
    - description (text)

  - sales
    - id (int PK)
    - customer_id (int FK)
    - total (decimal)
    - transaction_date (datetime)
    
  - sales_detail
    - id (int PK)
    - item_id (int FK)
    - amount (int)
    - sub_total (decimal)

## Asset wkwk
<img src="nurhadi.png" width="100%">