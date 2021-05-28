using System;
using Books.Catalog.Core.Assertions;
using Shouldly;
using Xunit;

namespace Books.Catalog.Core.UnitTests.Assertions
{
    public class GuardTests
    {
        [Fact]
        public void IsNotNull_WhenValueIsNull_ThenThrowsArgumentNullException()
        {
            string value = null;

            Should.Throw<ArgumentNullException>(() => Guard.IsNotNull(value, nameof(value)));
        }
        
        [Fact]
        public void IsNotNull_WhenValueIsNotNull_ThenThrowsNoException()
        {
            var value = string.Empty;

            Guard.IsNotNull(value, nameof(value));
        } 
        
        [Fact]
        public void IsNotNull_WhenValueIsDefault_ThenThrowsArgumentException()
        {
            Guid value = default;

            Should.Throw<ArgumentException>(() => Guard.IsNotDefault(value, nameof(value)));
        }
        
        [Fact]
        public void IsNotDefault_WhenValueIsNotDefault_ThenThrowsNoException()
        {
            Guid value = Guid.NewGuid();

            Guard.IsNotDefault(value, nameof(value));
        }
        
        [Fact]
        public void IsNotNullOrWhiteSpace_WhenValueIsNull_ThenThrowsArgumentException()
        {
            string value = null;

            Should.Throw<ArgumentException>(() => Guard.IsNotNullOrWhitespace(value, nameof(value)));
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_WhenValueIsWhiteSpace_ThenThrowsArgumentException()
        {
            var value = " ";
            
            Should.Throw<ArgumentException>(() => Guard.IsNotNullOrWhitespace(value, nameof(value)));
        }
        
        [Fact]
        public void IsNotNullOrWhitespace_WhenValueIsNotNullOrWhiteSpace_ThenThrowsNoException()
        {
            var value = "Value";

            Guard.IsNotNullOrWhitespace(value, nameof(value));
        }


        [Fact]
        public void DoesNotExceedLength_WhenValueIsNull_ThenDoesNotThrowException()
        {
            string value = null;

            Guard.DoesNotExceedLength(1, value, nameof(value));
        }

        [Fact]
        public void DoesNotExceedLength_WhenExceedsLength_ThenThrowsArgumentException()
        {
            var value = "12";
            
            Should.Throw<ArgumentException>(() => Guard.DoesNotExceedLength(1, value, nameof(value)));
        }
    }
}
