// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.ActiveAmountRange3Choice
{
    /// <summary>
    /// Expresses an amount or an amount range with an explicit debit/credit indicator and where the currency is implied.
    /// </summary>
    [IsoId("_OvM9s5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Implied Currency And Amount Range")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ImpliedCurrencyAndAmountRange : ActiveAmountRange3Choice_
    #else
    public partial class ImpliedCurrencyAndAmountRange : ActiveAmountRange3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ImpliedCurrencyAndAmountRange instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ImpliedCurrencyAndAmountRange( ImpliedCurrencyAmountRange1Choice_ reqAmount )
        {
            Amount = reqAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// A specified amount or amount range.
        /// </summary>
        [IsoId("_O3sLUZlcEeeE1Ya-LgRsuQ")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt")]
        #endif
        [IsoXmlTag("Amt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ImpliedCurrencyAmountRange1Choice_ Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ImpliedCurrencyAmountRange1Choice_ Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ImpliedCurrencyAmountRange1Choice_ Amount { get; init; } 
        #else
        public ImpliedCurrencyAmountRange1Choice_ Amount { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the amount is a credited or debited amount.
        /// </summary>
        [IsoId("_O3sLU5lcEeeE1Ya-LgRsuQ")]
        [DisplayName("Credit Debit Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtDbtInd")]
        #endif
        [IsoXmlTag("CdtDbtInd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CreditDebitCode? CreditDebitIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CreditDebitCode? CreditDebitIndicator { get; init; } 
        #else
        public CreditDebitCode? CreditDebitIndicator { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
