# 📧 Notifications API — FIAP Cloud Games

Este microsserviço é responsável por consumir eventos da plataforma FIAP Cloud Games e simular o envio de notificações por e-mail, utilizando logs no console.

Ele faz parte da Fase 2 do Tech Challenge – Pós Tech FIAP, que propõe uma arquitetura de microsserviços orientada a eventos.

---

## 📌 Responsabilidades

- Consumir eventos de cadastro de usuário
- Consumir eventos de processamento de pagamento
- Simular envio de e-mails (log no console)

---

## 📥 Eventos Consumidos

### 🔹 UserCreatedEvent
Evento disparado quando um novo usuário é cadastrado com sucesso.

Ação executada  
Simula o envio de um e-mail de boas-vindas para o usuário.

---

### 🔹 PaymentProcessedEvent
Evento disparado após o processamento de um pagamento.

Ação executada  
Se o pagamento for aprovado (`Approved`), simula o envio de um e-mail de confirmação de compra.

Payload exemplo
```json
{
  orderId guid,
  userId guid,
  status Approved,
  processedAt 2026-01-01T121000Z
}
