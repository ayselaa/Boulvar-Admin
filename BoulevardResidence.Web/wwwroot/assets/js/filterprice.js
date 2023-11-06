// PRICE RANGE
const priceRanges = document.querySelectorAll('.js-price-range');

priceRanges.forEach(el => {
    const downPriceInput = el.closest('.filter-price').querySelector('.js-price-down');
    const upPriceInput = el.closest('.filter-price').querySelector('.js-price-up');
    const inputs = [downPriceInput, upPriceInput];

    // Get maxPrice for slider price
    const maxPrice = +upPriceInput.getAttribute('data-max');
    upPriceInput.value = maxPrice.toLocaleString();

    // Init price range slider
    noUiSlider.create(el, {
        range: {
            'min': 0,
            'max': maxPrice
        },
        behaviour: 'drag',
        connect: true,
        start: [0, maxPrice],
        step: 1
    });

    // Update value after scroll pointer in slider
    el.noUiSlider.on('update', values => {
        let [downPrice, upPrice] = values;

        downPrice = Number(downPrice).toLocaleString();
        upPrice = Number(upPrice).toLocaleString();

        downPriceInput.value = downPrice;
        upPriceInput.value = upPrice;
    });

    // Change slider value after inputs change
    inputs.forEach(function (input, handle) {
        input.addEventListener('change', function () {
            let value = this.value;
            value = value.replace(/\s+/g, '');
            value = parseInt(value);

            el.noUiSlider.setHandle(handle, value);
        });
    });
});

// Clear sliders value
const clearBtn = document.querySelector('.js-clear-sliders');

clearBtn.addEventListener('click', () => {
    const filterPrices = document.querySelectorAll('.filter-price');

    filterPrices.forEach(el => {
        const priceRange = el.querySelector('.js-price-range');
        const priceRangeInputs = el.querySelectorAll('.filter-price__flex-row input');

        priceRangeInputs.forEach(function (input, handle) {
            const maxPrice = (handle) ? input.getAttribute('data-max') : 0;

            priceRange.noUiSlider.setHandle(handle, maxPrice);
        });
    });
});
