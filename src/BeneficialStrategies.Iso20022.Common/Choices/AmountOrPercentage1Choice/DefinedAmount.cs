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
namespace BeneficialStrategies.Iso20022.Choices.AmountOrPercentage1Choice
{
    /// <summary>
    /// Details related to a defined monetary amount.
    /// </summary>
    [IsoId("_986x53ltEeG7BsjMvd1mEw_-1070364431")]
    [DisplayName("Defined Amount")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DefinedAmount : AmountOrPercentage1Choice_
    #else
    public partial class DefinedAmount : AmountOrPercentage1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DefinedAmount instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DefinedAmount( ActiveCurrencyAndAmount reqVariationAmount )
        {
            VariationAmount = reqVariationAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Variation amount and currency.
        /// </summary>
        [IsoId("_945NhHltEeG7BsjMvd1mEw_1236951493")]
        [DisplayName("Variation Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VartnAmt")]
        #endif
        [IsoXmlTag("VartnAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAndAmount VariationAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAndAmount VariationAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount VariationAmount { get; init; } 
        #else
        public ActiveCurrencyAndAmount VariationAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Calculated undertaking available balance amount resulting from the application of the variation amount.
        /// </summary>
        [IsoId("_95C-gHltEeG7BsjMvd1mEw_1336485232")]
        [DisplayName("Balance Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BalAmt")]
        #endif
        [IsoXmlTag("BalAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveCurrencyAndAmount? BalanceAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount? BalanceAmount { get; init; } 
        #else
        public ActiveCurrencyAndAmount? BalanceAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
