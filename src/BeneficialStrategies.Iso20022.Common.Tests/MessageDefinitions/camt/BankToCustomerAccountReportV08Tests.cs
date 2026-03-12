using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;
using System.Reflection;

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Tests for <see cref="BankToCustomerAccountReportV08"/> demonstrating that
/// GitHub Issue #1 has been resolved: collections are now properly typed as ValueList&lt;T&gt;
/// instead of single values.
/// </summary>
public class BankToCustomerAccountReportV08Tests
{
    /// <summary>
    /// Creates a minimal valid GroupHeader81 for testing purposes.
    /// </summary>
    private static GroupHeader81 CreateGroupHeader() => new GroupHeader81
    {
        MessageIdentification = "MSG-001",
        CreationDateTime = DateTime.UtcNow
    };

    /// <summary>
    /// Creates a minimal valid AccountReport25 for testing purposes.
    /// </summary>
    private static AccountReport25 CreateAccountReport(string id = "RPT-001") => new AccountReport25
    {
        Identification = id,
        Account = new CashAccount39
        {
            Identification = new IBAN { Value = "DE89370400440532013000" }
        }
    };

    [Fact]
    public void CanInstantiate_WithRequiredProperties()
    {
        // Arrange & Act
        var message = new BankToCustomerAccountReportV08
        {
            GroupHeader = CreateGroupHeader()
        };

        // Assert
        Assert.NotNull(message);
        Assert.NotNull(message.GroupHeader);
        Assert.Equal("MSG-001", message.GroupHeader.MessageIdentification);
    }

    [Fact]
    public void IsoIdentifier_IsCorrect()
    {
        // Assert
        Assert.Equal("camt.052.001.08", BankToCustomerAccountReportV08.IsoIdentifier);
    }

    /// <summary>
    /// Issue #1: Report was incorrectly typed as a single AccountReport25.
    /// This test proves it is now a collection that can hold multiple reports.
    /// </summary>
    [Fact]
    public void Report_CanHoldMultipleItems_Issue1Fixed()
    {
        // Arrange
        var message = new BankToCustomerAccountReportV08
        {
            GroupHeader = CreateGroupHeader()
        };

        // Act - Add multiple reports (this would fail if Report was a single value)
        message.Report.Add(CreateAccountReport("RPT-001"));
        message.Report.Add(CreateAccountReport("RPT-002"));
        message.Report.Add(CreateAccountReport("RPT-003"));

        // Assert
        Assert.Equal(3, message.Report.Count);
        Assert.Equal("RPT-001", message.Report[0].Identification);
        Assert.Equal("RPT-002", message.Report[1].Identification);
        Assert.Equal("RPT-003", message.Report[2].Identification);
    }

    /// <summary>
    /// Issue #1: SupplementaryData was incorrectly typed as a single SupplementaryData1?.
    /// This test proves it is now a collection (ValueList) by checking the type.
    /// </summary>
    [Fact]
    public void SupplementaryData_IsValueListCollection_Issue1Fixed()
    {
        // Arrange
        var message = new BankToCustomerAccountReportV08
        {
            GroupHeader = CreateGroupHeader()
        };

        // Assert - SupplementaryData should be a ValueList<T>, not a single value
        var propertyType = typeof(BankToCustomerAccountReportV08)
            .GetProperty(nameof(BankToCustomerAccountReportV08.SupplementaryData))!
            .PropertyType;

        Assert.True(propertyType.IsGenericType, "SupplementaryData should be a generic type (ValueList<T>)");
        Assert.Equal("ValueList`1", propertyType.Name);
        Assert.NotNull(message.SupplementaryData);
        Assert.Empty(message.SupplementaryData);
    }

    [Fact]
    public void Report_IsInitializedAsEmptyCollection()
    {
        // Arrange & Act
        var message = new BankToCustomerAccountReportV08
        {
            GroupHeader = CreateGroupHeader()
        };

        // Assert - Collection is initialized and ready to use
        Assert.NotNull(message.Report);
        Assert.Empty(message.Report);
    }

    [Fact]
    public void SupplementaryData_IsInitializedAsEmptyCollection()
    {
        // Arrange & Act
        var message = new BankToCustomerAccountReportV08
        {
            GroupHeader = CreateGroupHeader()
        };

        // Assert - Collection is initialized and ready to use
        Assert.NotNull(message.SupplementaryData);
        Assert.Empty(message.SupplementaryData);
    }

    /// <summary>
    /// Per ISO20022 spec, the Report collection has MinLength(1), meaning at least
    /// one report is required for a valid message.
    /// </summary>
    [Fact]
    public void Report_HasMinLengthAttribute_RequiringAtLeastOneReport()
    {
        // Arrange
        var reportProperty = typeof(BankToCustomerAccountReportV08).GetProperty(nameof(BankToCustomerAccountReportV08.Report));

        // Act
        var minLengthAttr = reportProperty?.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.MinLengthAttribute), false)
            .Cast<System.ComponentModel.DataAnnotations.MinLengthAttribute>()
            .FirstOrDefault();

        // Assert
        Assert.NotNull(minLengthAttr);
        Assert.Equal(1, minLengthAttr.Length);
    }

    /// <summary>
    /// Verifies that Report property type is ValueList&lt;AccountReport25&gt;, not AccountReport25.
    /// This is the core fix for Issue #1.
    /// </summary>
    [Fact]
    public void Report_PropertyType_IsValueList_NotSingleValue()
    {
        // Arrange
        var reportProperty = typeof(BankToCustomerAccountReportV08)
            .GetProperty(nameof(BankToCustomerAccountReportV08.Report));

        // Act
        var propertyType = reportProperty!.PropertyType;

        // Assert - Should be ValueList<AccountReport25>, not AccountReport25
        Assert.True(propertyType.IsGenericType);
        Assert.Equal("ValueList`1", propertyType.Name);
        Assert.Equal(typeof(AccountReport25), propertyType.GetGenericArguments()[0]);
    }
}
