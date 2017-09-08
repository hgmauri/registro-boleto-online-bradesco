# RegistroBoletoOnlineBradesco
Integração com banco Bradesco de remessa de cobrança online em formato JSON

Pré-Requisitos:

- Certificado tipo A1 e-cpf ou e-cnpj com chave privada emitido por autoridade participante do ICP-Brasil
- Biblioteca Bouncy Castle: http://www.bouncycastle.org/csharp/index.html
- Biblioteca Newtonsoft.Json
- JSON com aspas duplas

Erros comuns:

- Permissão do certificado: após instalado na máquina se faz necessário conceder permissão ao usuário que está executando o código. (CryptographicException 'Keyset does not exist')
- Não encontrou o certificado: o código lê certificados que se encontram na pasta Pessoal da máquina local, é possível instalar certificado em diversos grupos/pastas e em repositórios distintos como máquina local ou usuários específicos, atentar a isso.
