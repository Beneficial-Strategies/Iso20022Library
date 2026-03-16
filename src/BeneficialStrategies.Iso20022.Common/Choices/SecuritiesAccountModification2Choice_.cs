// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifies which information are involved by a modification request for securities account reference data.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountModification2Choice.SystemSecuritiesAccount))]
    [KnownType(typeof(SecuritiesAccountModification2Choice.SystemRestriction))]
    [KnownType(typeof(SecuritiesAccountModification2Choice.MarketSpecificAttribute))]
    [JsonDerivedType(
        typeof(SecuritiesAccountModification2Choice.SystemSecuritiesAccount),
        nameof(SecuritiesAccountModification2Choice.SystemSecuritiesAccount)
    )]
    [JsonDerivedType(
        typeof(SecuritiesAccountModification2Choice.SystemRestriction),
        nameof(SecuritiesAccountModification2Choice.SystemRestriction)
    )]
    [JsonDerivedType(
        typeof(SecuritiesAccountModification2Choice.MarketSpecificAttribute),
        nameof(SecuritiesAccountModification2Choice.MarketSpecificAttribute)
    )]
    [IsoId("_7-eWJTp0Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Modification 2 Choice")]
    public abstract record SecuritiesAccountModification2Choice_ { }
}
