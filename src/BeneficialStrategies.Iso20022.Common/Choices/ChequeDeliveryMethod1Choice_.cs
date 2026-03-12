// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
    /// </summary>
    [KnownType(typeof(ChequeDeliveryMethod1Choice.Code))]
    [KnownType(typeof(ChequeDeliveryMethod1Choice.Proprietary))]
    [JsonDerivedType(typeof(ChequeDeliveryMethod1Choice.Code),nameof(ChequeDeliveryMethod1Choice.Code))]
    [JsonDerivedType(typeof(ChequeDeliveryMethod1Choice.Proprietary),nameof(ChequeDeliveryMethod1Choice.Proprietary))]
    [IsoId("_QbwF5tp-Ed-ak6NoX_4Aeg_258234806")]
    [DisplayName("Cheque Delivery Method 1 Choice")]
    public abstract partial record ChequeDeliveryMethod1Choice_
    {
    }
}
