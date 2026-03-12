// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the account type.
    /// </summary>
    [KnownType(typeof(PurposeCode2Choice.Code))]
    [KnownType(typeof(PurposeCode2Choice.Proprietary))]
    [JsonDerivedType(typeof(PurposeCode2Choice.Code),nameof(PurposeCode2Choice.Code))]
    [JsonDerivedType(typeof(PurposeCode2Choice.Proprietary),nameof(PurposeCode2Choice.Proprietary))]
    [IsoId("_Qwdxotp-Ed-ak6NoX_4Aeg_264236382")]
    [DisplayName("Purpose Code 2 Choice")]
    public abstract partial record PurposeCode2Choice_
    {
    }
}
