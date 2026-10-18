// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification3Choice;

/// <summary>
/// Account number used by financial institutions in individual countries to identify an account of a customer, but not necessarily the bank and branch of the financial institution in which the account is held.
/// </summary>
[IsoId("_PdwzoNp-Ed-ak6NoX_4Aeg_-1485477198")]
public interface IProprietaryAccount : IAccountIdentification3Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    [IsoId("_P_u4QNp-Ed-ak6NoX_4Aeg_618188642")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    Max34Text Identification { get; }
}
