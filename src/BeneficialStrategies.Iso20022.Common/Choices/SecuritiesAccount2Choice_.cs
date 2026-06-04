// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SecuritiesAccount2Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies one or a range of securities accounts.</summary>
    [IsoId("_38iun-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Securities Account 2 Choice")]
    [KnownType(typeof(SecuritiesAccount2Choice.Range))]
    [KnownType(typeof(SecuritiesAccount2Choice.Account))]
    [JsonDerivedType(typeof(SecuritiesAccount2Choice.Range))]
    [JsonDerivedType(typeof(SecuritiesAccount2Choice.Account))]
    public abstract record SecuritiesAccount2Choice_
    {
    }
}
