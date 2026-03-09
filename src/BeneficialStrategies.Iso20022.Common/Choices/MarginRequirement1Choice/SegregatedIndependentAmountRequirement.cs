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
namespace BeneficialStrategies.Iso20022.Choices.MarginRequirement1Choice
{
    /// <summary>
    /// Provides details about the margin requirements for the segregated independent amount only.
    /// </summary>
    [IsoId("_QmogMdp-Ed-ak6NoX_4Aeg_-911647050")]
    [DisplayName("Segregated Independent Amount Requirement")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SegregatedIndependentAmountRequirement : MarginRequirement1Choice_
    #else
    public partial class SegregatedIndependentAmountRequirement : MarginRequirement1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Amount of new margin that will be delivered to one party by the other party after rounding, threshold and minimum transfer amount are taken into account.
        /// </summary>
        [IsoId("_Ul4kAdp-Ed-ak6NoX_4Aeg_1961004215")]
        [DisplayName("Deliver Margin Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DlvrMrgnAmt")]
        #endif
        [IsoXmlTag("DlvrMrgnAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveCurrencyAndAmount? DeliverMarginAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount? DeliverMarginAmount { get; init; } 
        #else
        public ActiveCurrencyAndAmount? DeliverMarginAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of new margin that will be recalled to one party from the other party after rounding, threshold and minimum transfer amount are taken into account.
        /// </summary>
        [IsoId("_Ul4kAtp-Ed-ak6NoX_4Aeg_-1890638845")]
        [DisplayName("Return Margin Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RtrMrgnAmt")]
        #endif
        [IsoXmlTag("RtrMrgnAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveCurrencyAndAmount? ReturnMarginAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount? ReturnMarginAmount { get; init; } 
        #else
        public ActiveCurrencyAndAmount? ReturnMarginAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
