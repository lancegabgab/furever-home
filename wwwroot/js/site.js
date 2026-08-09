// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const customizedSwal = (options = {}) => {
    return Swal.fire({
        ...options,
        customClass: {
            popup: "furever-swal-popup",
            confirmButton: "furever-swal-confirm",
            cancelButton: "furever-swal-cancel"
        },
        buttonsStyling: false
    });
};

$("#btnLogout").click(function () {
    customizedSwal({
        title: "Are you sure?",
        text: "You will be logged out of your account.",
        icon: "warning",
        showCancelButton: true,
        confirmButtonText: "Yes",
        cancelButtonText: "Cancel"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: "/Account/Logout",
                type: "POST",
                success: function (res) {
                    if (res.success) {
                        customizedSwal({
                            icon: "success",
                            title: res.message,
                            timer: 1500,
                            showConfirmButton: false
                        }).then(() => {
                            window.location.href = "/Account/Login";
                        });
                    }
                },
                error: function () {
                    customizedSwal({
                        icon: "error",
                        title: "Error",
                        text: "Unable to logout."
                    });
                }
            });
        }
    });
});