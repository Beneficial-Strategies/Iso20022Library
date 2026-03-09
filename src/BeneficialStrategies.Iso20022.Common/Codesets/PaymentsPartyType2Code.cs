// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// CodeSet identifying parties involved in a payments transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_C4Fi8FyZEeewBcMu1EH_Gg")]
[Description(@"CodeSet identifying parties involved in a payments transaction.")]
[DerivedFrom(typeof(PaymentsPartyTypeCode))]
public enum PaymentsPartyType2Code
{
    /// <summary>
    /// Creditor agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.
    /// Encoded/decoded by serializers as &quot;CACR&quot;.
    /// </summary>
    [EnumMember(Value = "CACR")]
    [IsoId("_IKhF4VyZEeewBcMu1EH_Gg")]
    [Description(@"Creditor agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.")]
    CreditorAgentOrCreditor = PaymentsPartyTypeCode.CreditorAgentOrCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.
    /// Encoded/decoded by serializers as &quot;DADE&quot;.
    /// </summary>
    [EnumMember(Value = "DADE")]
    [IsoId("_IRPY8VyZEeewBcMu1EH_Gg")]
    [Description(@"Debtor agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.")]
    DebtorAgentOrDebtor = PaymentsPartyTypeCode.DebtorAgentOrDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Intermediary agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.
    /// Encoded/decoded by serializers as &quot;INAG&quot;.
    /// </summary>
    [EnumMember(Value = "INAG")]
    [IsoId("_IWyAQVyZEeewBcMu1EH_Gg")]
    [Description(@"Intermediary agent in a financial institution to financial institution customer credit transfer or creditor in a financial institution credit transfer with cover.")]
    IntermediaryAgent = PaymentsPartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions
    
}
