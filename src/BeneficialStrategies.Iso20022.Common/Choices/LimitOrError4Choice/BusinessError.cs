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
namespace BeneficialStrategies.Iso20022.Choices.LimitOrError4Choice
{
    /// <summary>
    /// Reason the requested business information is not given.
    /// </summary>
    [IsoId("_RixMQ3hdEeidzqjNEfehPg")]
    [DisplayName("Business Error")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record BusinessError : LimitOrError4Choice_
    #else
    public partial class BusinessError : LimitOrError4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a BusinessError instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public BusinessError( ErrorHandling3Choice_ reqError )
        {
            Error = reqError;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specification of the error, in coded or proprietary form.
        /// </summary>
        [IsoId("_RA_78XhdEeidzqjNEfehPg")]
        [DisplayName("Error")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Err")]
        #endif
        [IsoXmlTag("Err")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ErrorHandling3Choice_ Error { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ErrorHandling3Choice_ Error { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ErrorHandling3Choice_ Error { get; init; } 
        #else
        public ErrorHandling3Choice_ Error { get; set; } 
        #endif
        
        /// <summary>
        /// Specification of the error, in free format.
        /// </summary>
        [IsoId("_RA_783hdEeidzqjNEfehPg")]
        [DisplayName("Description")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Desc")]
        #endif
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax140Text? Description { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Description { get; init; } 
        #else
        public System.String? Description { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
