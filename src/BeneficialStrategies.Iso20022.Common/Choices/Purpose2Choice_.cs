// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [KnownType(typeof(Purpose2Choice.Code))]
    [KnownType(typeof(Purpose2Choice.Proprietary))]
    [JsonDerivedType(typeof(Purpose2Choice.Code),nameof(Purpose2Choice.Code))]
    [JsonDerivedType(typeof(Purpose2Choice.Proprietary),nameof(Purpose2Choice.Proprietary))]
    [IsoId("_P6qyHtp-Ed-ak6NoX_4Aeg_-1283223379")]
    [DisplayName("Purpose 2 Choice")]
    public abstract partial record Purpose2Choice_
    {
    }
}
