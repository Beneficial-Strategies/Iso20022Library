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
namespace BeneficialStrategies.Iso20022.Choices.MemberReportOrError7Choice
{
    /// <summary>
    /// Indicates that an operational error has been issued during the processing of the related request.
    /// </summary>
    [IsoId("_fODoU9cZEeqRFcf2R4bPBw")]
    [DisplayName("Operational Error")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OperationalError : MemberReportOrError7Choice_
    #else
    public partial class OperationalError : MemberReportOrError7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OperationalError instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OperationalError( ErrorHandling1Choice_ reqError )
        {
            Error = reqError;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specification of the error, in coded or proprietary form.
        /// </summary>
        [IsoId("_RY_xStp-Ed-ak6NoX_4Aeg_-487033921")]
        [DisplayName("Error")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Err")]
        #endif
        [IsoXmlTag("Err")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ErrorHandling1Choice_ Error { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ErrorHandling1Choice_ Error { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ErrorHandling1Choice_ Error { get; init; } 
        #else
        public ErrorHandling1Choice_ Error { get; set; } 
        #endif
        
        /// <summary>
        /// Specification of the error, in free format.
        /// </summary>
        [IsoId("_RZI7MNp-Ed-ak6NoX_4Aeg_-917396614")]
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
