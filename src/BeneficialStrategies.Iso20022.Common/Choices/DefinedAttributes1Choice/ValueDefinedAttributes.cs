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
namespace BeneficialStrategies.Iso20022.Choices.DefinedAttributes1Choice
{
    /// <summary>
    /// Value defined attributes for derivatives where the terms of the contract define the value of payable per unit of a move in some published index. This includes the floating leg of interest rate swaps which implicitly are payments proportional to the change in the index.
    /// </summary>
    [IsoId("__F7tMePJEea7_eMQH225xA")]
    [DisplayName("Value Defined Attributes")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ValueDefinedAttributes : DefinedAttributes1Choice_
    #else
    public partial class ValueDefinedAttributes : DefinedAttributes1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ValueDefinedAttributes instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ValueDefinedAttributes( ActiveCurrencyAndAmount reqUnitValue,GenericIdentification168 reqIndexIdentification,System.String reqIndexUnit )
        {
            UnitValue = reqUnitValue;
            IndexIdentification = reqIndexIdentification;
            IndexUnit = reqIndexUnit;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reference notional amount of the contract.
        /// </summary>
        [IsoId("_jjd08chlEeadgvwNGwK05w")]
        [DisplayName("Notional")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ntnl")]
        #endif
        [IsoXmlTag("Ntnl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveCurrencyAndAmount? Notional { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount? Notional { get; init; } 
        #else
        public ActiveCurrencyAndAmount? Notional { get; set; } 
        #endif
        
        /// <summary>
        /// Value of unit move in index if fixed in contract terms, and currency of payments relating to changes in the amount of the underlying.
        /// </summary>
        [IsoId("_jjd088hlEeadgvwNGwK05w")]
        [DisplayName("Unit Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnitVal")]
        #endif
        [IsoXmlTag("UnitVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAndAmount UnitValue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAndAmount UnitValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount UnitValue { get; init; } 
        #else
        public ActiveCurrencyAndAmount UnitValue { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identifier for underlying index on which final settlement price or periodic payments are calculated.
        /// </summary>
        [IsoId("_jjd09chlEeadgvwNGwK05w")]
        [DisplayName("Index Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IndxId")]
        #endif
        [IsoXmlTag("IndxId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericIdentification168 IndexIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GenericIdentification168 IndexIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification168 IndexIdentification { get; init; } 
        #else
        public GenericIdentification168 IndexIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unit index, typically ‘Points’, or for interest rate and CDS products, ‘Bps’.
        /// </summary>
        [IsoId("_HF0BMMhoEeadgvwNGwK05w")]
        [DisplayName("Index Unit")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IndxUnit")]
        #endif
        [IsoXmlTag("IndxUnit")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text IndexUnit { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String IndexUnit { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String IndexUnit { get; init; } 
        #else
        public System.String IndexUnit { get; set; } 
        #endif
        
        /// <summary>
        /// Day count convention for interest payments. Interest rate products only.
        /// </summary>
        [IsoId("_NMr40MhoEeadgvwNGwK05w")]
        [DisplayName("Interest Rate Terms")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrstRateTerms")]
        #endif
        [IsoXmlTag("IntrstRateTerms")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestComputationMethod2Code? InterestRateTerms { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestComputationMethod2Code? InterestRateTerms { get; init; } 
        #else
        public InterestComputationMethod2Code? InterestRateTerms { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
