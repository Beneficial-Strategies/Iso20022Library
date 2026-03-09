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
namespace BeneficialStrategies.Iso20022.Choices.ClassificationType30Choice
{
    /// <summary>
    /// ISO 10962 Classification of Financial Instrument (CFI).
    /// </summary>
    [IsoId("_AbpPo9okEeC60axPepSq7g_257428123")]
    [DisplayName("Classification Financial Instrument")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ClassificationFinancialInstrument : ClassificationType30Choice_
    #else
    public partial class ClassificationFinancialInstrument : ClassificationType30Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ClassificationFinancialInstrument instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ClassificationFinancialInstrument( System.String reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Classification type of the financial instrument, as per the ISO 10962 Classification of Financial Instrument (CFI) codification, eg, common share with voting rights, fully paid, or registered.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClssfctnFinInstrm")]
        #endif
        [IsoXmlTag("ClssfctnFinInstrm")]
        [IsoSimpleType(IsoSimpleType.CFIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoCFIIdentifier Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Value { get; init; } 
        #else
        public System.String Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
