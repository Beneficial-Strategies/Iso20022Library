// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a national central bank or a payment bank.
    /// </summary>
    [KnownType(typeof(NCBOrPaymentBank1Choice.NCBIdentification))]
    [KnownType(typeof(NCBOrPaymentBank1Choice.PaymentBankIdentification))]
    [JsonDerivedType(typeof(NCBOrPaymentBank1Choice.NCBIdentification),nameof(NCBOrPaymentBank1Choice.NCBIdentification))]
    [JsonDerivedType(typeof(NCBOrPaymentBank1Choice.PaymentBankIdentification),nameof(NCBOrPaymentBank1Choice.PaymentBankIdentification))]
    [IsoId("_jAtUBO5NEeCisYr99QEiWA_-1552282383")]
    [DisplayName("NCB Or Payment Bank 1 Choice")]
    public abstract partial record NCBOrPaymentBank1Choice_
    {
    }
}
