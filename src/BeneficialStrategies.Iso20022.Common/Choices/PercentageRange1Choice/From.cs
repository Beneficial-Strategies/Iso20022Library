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
namespace BeneficialStrategies.Iso20022.Choices.PercentageRange1Choice
{
    /// <summary>
    /// Lower boundary of a range of percentage rates.
    /// </summary>
    [IsoId("_7_BRqaMgEeCJ6YNENx4h-w_-1383081859")]
    [DisplayName("From")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record From : PercentageRange1Choice_
    #else
    public partial class From : PercentageRange1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a From instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public From( System.Decimal reqBoundaryRate,System.String reqIncluded )
        {
            BoundaryRate = reqBoundaryRate;
            Included = reqIncluded;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Percentage rate of the range limit.
        /// </summary>
        [IsoId("_8GekiKMgEeCJ6YNENx4h-w_1727044493")]
        [DisplayName("Boundary Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BdryRate")]
        #endif
        [IsoXmlTag("BdryRate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoPercentageRate BoundaryRate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Decimal BoundaryRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal BoundaryRate { get; init; } 
        #else
        public System.Decimal BoundaryRate { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the boundary percentage rate is included in the range of percentage rates.
        /// </summary>
        [IsoId("_8GekiaMgEeCJ6YNENx4h-w_-1807157650")]
        [DisplayName("Included")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Incl")]
        #endif
        [IsoXmlTag("Incl")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoYesNoIndicator Included { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Included { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Included { get; init; } 
        #else
        public System.String Included { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
