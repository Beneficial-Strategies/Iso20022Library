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
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice
{
    /// <summary>
    /// Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to identify foreign stocks, especially those that aren&apos;t actively traded in the US and don&apos;t have a CUSIP number.
    /// </summary>
    [IsoId("_Qdr_kdp-Ed-ak6NoX_4Aeg_1796754500")]
    [DisplayName("SEDOL")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SEDOL : SecurityIdentification3Choice_
    #else
    public partial class SEDOL : SecurityIdentification3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SEDOL instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SEDOL( System.String reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to identify foreign stocks, especially those that aren&apos;t actively traded in the US and don&apos;t have a CUSIP number.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SEDOL")]
        #endif
        [IsoXmlTag("SEDOL")]
        [IsoSimpleType(IsoSimpleType.SEDOLIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoSEDOLIdentifier Value { get; init; } 
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
