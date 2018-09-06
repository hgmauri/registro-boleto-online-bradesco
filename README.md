# RegistroBoletoOnlineBradesco
Integração com banco Bradesco de remessa de cobrança online em formato JSON

Pré-Requisitos:

- Certificado tipo A1 e-cpf ou e-cnpj com chave privada emitido por autoridade participante do ICP-Brasil
- Biblioteca Bouncy Castle: http://www.bouncycastle.org/csharp/index.html
- Biblioteca Newtonsoft.Json
- JSON com aspas duplas
- Todos os campos não obrigatórios numéricos do JSON devem ser: "0" e os alfanuméricos deverm ser: ""
- Ler o manual: [Manual Registro de Boleto Bancário On-line_v 2_0.pdf]

Erros comuns:

- Permissão do certificado: após instalado na máquina se faz necessário conceder permissão ao usuário que está executando o código. (CryptographicException 'Keyset does not exist') Solução: https://stackoverflow.com/questions/12106011/system-security-cryptography-cryptographicexception-keyset-does-not-exist
- Não encontrou o certificado: o código lê certificados que se encontram na pasta Pessoal da máquina local, é possível instalar certificado em diversos grupos/pastas e em repositórios distintos como máquina local ou usuários específicos, atentar a isso.
- Não está assinando o documento: Verificar se o certificado é do tipo A1 emitido pelo ICP-Brasil


Agradecimentos
- @Gread pelo apoio, dicas e códigos
- @BoletoNet pelo forum de conhecimento

[Manual Registro de Boleto Bancário On-line_v 2_0.pdf]: <https://github.com/hgmauri/RegistroBoletoOnlineBradesco/raw/master/BoletoOnline.Class/Manual_Registro_de_Boleto_Bancario_Online_Mar18.pdf>
