
CREATE Procedure InsereCliente(        
  @NomeCliente varchar(100)          
 )        
 AS BEGIN         
       
 insert into Cliente(Nome) values(        
 @NomeCliente       
 )   

 end
