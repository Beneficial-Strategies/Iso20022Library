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
namespace BeneficialStrategies.Iso20022.Choices.PortfolioCode3Choice
{
    /// <summary>
    /// Collateralisation was performed on a transaction level basis or if the collateral portfolio code is not known at the time of reporting.
    /// </summary>
    [IsoId("_WOwWc1zGEeyTL-yEabFeNg")]
    [DisplayName("No Portfolio")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NoPortfolio : PortfolioCode3Choice_
    #else
    public partial class NoPortfolio : PortfolioCode3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NoPortfolio instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NoPortfolio( NotApplicable1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies special purpose codes.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NoPrtfl")]
        #endif
        [IsoXmlTag("NoPrtfl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NotApplicable1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required NotApplicable1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NotApplicable1Code Value { get; init; } 
        #else
        public NotApplicable1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
