// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a national central bank or a payment bank.
    /// </summary>
    [KnownType(typeof(NCBOrPaymentBank1Choice.NCBIdentification))]
    [KnownType(typeof(NCBOrPaymentBank1Choice.PaymentBankIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NCBOrPaymentBank1Choice.NCBIdentification),nameof(NCBOrPaymentBank1Choice.NCBIdentification))]
    [JsonDerivedType(typeof(NCBOrPaymentBank1Choice.PaymentBankIdentification),nameof(NCBOrPaymentBank1Choice.PaymentBankIdentification))]
    #endif
    [IsoId("_jAtUBO5NEeCisYr99QEiWA_-1552282383")]
    [DisplayName("NCB Or Payment Bank 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NCBOrPaymentBank1Choice_
    #else
    public abstract partial class NCBOrPaymentBank1Choice_
    #endif
    {
    }
}
