// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Underlying reason for the payment transaction, eg, a charity payment, or a commercial agreement between the creditor and the debtor.
    /// </summary>
    [KnownType(typeof(PurposeChoice.Proprietary))]
    [KnownType(typeof(PurposeChoice.Code))]
    [JsonDerivedType(typeof(PurposeChoice.Proprietary), nameof(PurposeChoice.Proprietary))]
    [JsonDerivedType(typeof(PurposeChoice.Code), nameof(PurposeChoice.Code))]
    [IsoId("_Rbhg1dp-Ed-ak6NoX_4Aeg_1321046879")]
    [DisplayName("Purpose Choice")]
    public abstract record PurposeChoice_ { }
}
