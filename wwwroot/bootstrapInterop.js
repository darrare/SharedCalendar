window.bootstrapInterop = {
    showModal: function (id) {
        var el = document.getElementById(id);
        var modal = bootstrap.Modal.getOrCreateInstance(el);
        modal.show();
    },
    hideModal: function (id) {
        var el = document.getElementById(id);
        var modal = bootstrap.Modal.getOrCreateInstance(el);
        modal.hide();
    }
};
