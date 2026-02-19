[![Nuget version](https://img.shields.io/nuget/v/Money.Unifi)](https://www.nuget.org/packages/Money.Unify/)
[![Nuget downloads](https://img.shields.io/nuget/dt/Money.Unifi)](https://www.nuget.org/packages/Money.Unifi/)
# Money on Github

**Money on GitHub** contains C# written, extensible Common Language Runtime class libraries for all .NET programming languages. The project also aims to be extensible, allowing developers to customize and extend the functionality according to their needs.

**Money.Unifi** contains serializable class models for **UNIFI (ISO 20022) Payments messages**. This library is used, among other things, in **SEPA payment transactions** for serializing and deserializing **SEPA XML documents**.

In the context of SEPA payment processing, **Money.Unifi** is employed for the following purposes:

1. **SEPA Credit Transfer Initiation (SCT):** Used for SEPA bank-to-customer transfers (pain.001).

2. **Payment Status Report (Bank to Customer Reject, pain.002):** Provides information on rejected payments.

3. **SEPA Direct Debit Initiation (SDD):** Used for SEPA direct debit transactions (pain.008).

4. **Account Statement (camt.052):** Provides transaction details for bank-to-customer account reports.

5. **Bank to Customer Statement (camt.053):** Represents customer account statements.

6. **Debit Credit Notification (camt.054):** Covers batched debit and credit notifications.

Additionally, **Money.Unifi** is available as a [**NuGet package**](https://www.nuget.org/packages/Money.Unifi/), making it easier to integrate into your .NET projects.

## Author & Documentation
🔗 https://chstorb.github.io
