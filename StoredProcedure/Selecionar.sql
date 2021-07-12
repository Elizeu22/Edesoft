

CREATE Procedure [dbo].[Selecionar](    
    
 @IdCliente int    
 )    
    
 AS BEGIN    
select An.Nome as NomeAnimal,
An.Raca as RacaAnimal,
Cli.nome as NomeCliente
from Animal An inner join RelacaoClienteXAnimal ReCli on An.IdAnimal=ReCli.Id
inner join Cliente Cli on Cli.IdCliente=ReCli.Id
where Cli.IdCliente=@IdCliente
    
 END  