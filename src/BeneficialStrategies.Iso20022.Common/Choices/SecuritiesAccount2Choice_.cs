// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies one or a range of securities accounts.
    /// </summary>
    [KnownType(typeof(SecuritiesAccount2Choice.Range))]
    [KnownType(typeof(SecuritiesAccount2Choice.Account))]
    [JsonDerivedType(typeof(SecuritiesAccount2Choice.Range),nameof(SecuritiesAccount2Choice.Range))]
    [JsonDerivedType(typeof(SecuritiesAccount2Choice.Account),nameof(SecuritiesAccount2Choice.Account))]
    [IsoId("_38iun-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Securities Account 2 Choice")]
    public abstract partial record SecuritiesAccount2Choice_
    {
    }
}
