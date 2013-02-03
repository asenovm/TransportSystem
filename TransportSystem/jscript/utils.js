$(document).ready(function () {
    attachInputListeners();
    $('button.right').click(function () {
        var $intermediary = $('input[name="Intermediary Stop"]').last(),
							$insertee = $('<br/><label for="intermediary">Intermediary Stop</label><input type="text" name="intermediary" value="Intermediary Stop" />'),
							$container = $('form.container');
        $intermediary.after($insertee);
        $container.height($container.height() + 60);
        attachInputListeners();
    });
});

function attachInputListeners(){
		$('input').focus(function(){
			$(this).val('');
		});
		
		$('input').blur(function(){
			if(!$(this).val()){
				$(this).val($(this).attr('name'));
			}
			
		});
}
