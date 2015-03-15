$(document).ready(function(){

  //////////////////////////////////////////////////////////////////////////////////////////////
  // Mascaras de netrada
  
  //$('.date').mask('11/11/1111');
  $('.horaMinuto').mask('00:00');
  //$('.date_time').mask('00/00/0000 00:00:00');
  //$('.cep').mask('00000-000');
  //$('.phone').mask('0000-0000');
  //$('.phone_with_ddd').mask('(00) 0000-0000');
  //$('.phone_us').mask('(000) 000-0000');
  //$('.mixed').mask('AAA 000-S0S');
	$('.cpf').mask('000.000.000-00');
	$('.cnpj').mask('00.000.000/0000-00');
  //$('.money').mask('000.000.000.000.000,00', {reverse: true});
  //$('.money2').mask("#.##0,00", {reverse: true, maxlength: false});
  //$('.ip_address').mask('0ZZ.0ZZ.0ZZ.0ZZ', {translation: {'Z': {pattern: /[0-9]/, optional: true}});
  //$('.ip_address').mask('099.099.099.099');

});

// Classe de "usuário" correspondente ao UsuarioDataContract
function Usuario(data){
  this.Id = data.Id
  this.Login = data.Login;
  this.Email = data.Email;
  this.Status = data.Status;
  this.DescricaoDoStatus = data.DescricaoDoStatus;
}

// Classe de "tarefa de usuário" correspondente ao TarefaDataContract
