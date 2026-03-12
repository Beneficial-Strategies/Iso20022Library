// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the account type.
    /// </summary>
    [KnownType(typeof(PurposeCode3Choice.Code))]
    [KnownType(typeof(PurposeCode3Choice.Proprietary))]
    [JsonDerivedType(typeof(PurposeCode3Choice.Code),nameof(PurposeCode3Choice.Code))]
    [JsonDerivedType(typeof(PurposeCode3Choice.Proprietary),nameof(PurposeCode3Choice.Proprietary))]
    [IsoId("_XN-Akdp-Ed-ak6NoX_4Aeg_-1420247134")]
    [DisplayName("Purpose Code 3 Choice")]
    public abstract partial record PurposeCode3Choice_
    {
    }
}
