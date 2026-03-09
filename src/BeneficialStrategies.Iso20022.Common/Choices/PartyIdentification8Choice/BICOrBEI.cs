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
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification8Choice
{
    /// <summary>
    /// Identification of a party by a BIC and an Alternative Identifier.
    /// </summary>
    [IsoId("_Q7pG4Np-Ed-ak6NoX_4Aeg_1657637865")]
    [DisplayName("BIC Or BEI")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record BICOrBEI : PartyIdentification8Choice_
    #else
    public partial class BICOrBEI : PartyIdentification8Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a BICOrBEI instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public BICOrBEI( System.String reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BICOrBEI")]
        #endif
        [IsoXmlTag("BICOrBEI")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoAnyBICIdentifier Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Value { get; init; } 
        #else
        public System.String Value { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
        /// </summary>
        [IsoId("_QQkwp9p-Ed-ak6NoX_4Aeg_1555128116")]
        [DisplayName("Alternative Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AltrntvIdr")]
        #endif
        [IsoXmlTag("AltrntvIdr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [MinLength(0)]
        [MaxLength(10)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public SimpleValueList<System.String> AlternativeIdentifier { get; init; } = new SimpleValueList<System.String>(){};
        
        
        #nullable disable
        
    }
}
