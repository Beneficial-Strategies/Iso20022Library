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
namespace BeneficialStrategies.Iso20022.Choices.RepurchaseAgreementType1Choice
{
    /// <summary>
    /// Repurchase agreement where a single, pre-defined, financial instrument is sold and repurchased.
    /// </summary>
    [IsoId("_9ll4gLbqEeaqL_M7XFD7PQ")]
    [DisplayName("Specific Collateral")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SpecificCollateral : RepurchaseAgreementType1Choice_
    #else
    public partial class SpecificCollateral : RepurchaseAgreementType1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SpecificCollateral instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SpecificCollateral( FinancialInstrument59 reqFinancialInstrumentIdentification )
        {
            FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of collateral placed as security for repo.
        /// </summary>
        [IsoId("_u_BmAbcREeabfchHYoktpA")]
        [DisplayName("Financial Instrument Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstrmId")]
        #endif
        [IsoXmlTag("FinInstrmId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstrument59 FinancialInstrumentIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstrument59 FinancialInstrumentIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrument59 FinancialInstrumentIdentification { get; init; } 
        #else
        public FinancialInstrument59 FinancialInstrumentIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
